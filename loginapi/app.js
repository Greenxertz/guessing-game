const express = require("express");
const mysql = require("mysql");
const bcrypt = require('bcrypt');

// Create express app
const app = express();
// Middleware to parse JSON bodies
app.use(express.json());

// Setting up MySQL connection
const connection = mysql.createConnection({
  host: process.env.MYSQL_HOST || 'mysql',
  user: process.env.MYSQL_USER || 'root',
  password: process.env.MYSQL_PASSWORD || 'secret',
  database: process.env.MYSQL_DB || 'spotify_database',
  port: 3306,
});

const knexConfig = require('./knexfile.js');
const knex = require('knex')(knexConfig.development); // Assuming you're in development mode

// Example usage
knex.raw('SELECT 1+1 AS result')
  .then(() => {
    console.log('Database connected');
  })
  .catch(err => {
    console.error('Database connection error', err);
  });


// Function to establish connection and run migrations
async function initializeDatabase() {
  try {
    console.log("Connecting to the database...");
    await knex.raw('SELECT 1+1 AS result'); // Simple query to check the connection
    console.log("Connected to the database.");

    console.log("Running database migrations...");
    await knex.migrate.latest();
    console.log("Database migrations completed successfully.");

    //
    const spotify_details = { 
      clientID: '3255eb67936e45f2b8c8da7d271abf56', // <-- You normally put this in your .env file
      secretID: 'e59e758328024b31936d750a735f990d' // <-- You normally put in your .env file
    };

    knex('spotify_details').insert(spotify_details)
    .then(() => console.log("Data inserted"))
    .catch(err => console.error(err.message))
    .finally(() => knex.destroy());

  } catch (error) {
    console.error("Error initializing the database:", error);
    // Handle error or rethrow as needed
    throw error;
  }
}

// Start server and initialize database
const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
  initializeDatabase();
});


//collect data for spotify api 
app.get("/spotify-details", (req, res) => {
  const collectAccess = 'SELECT clientID, secretID FROM spotify_details';
  connection.query(collectAccess, (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send("Internal Server Error");
    } else {
    const spotifyDetails = results.map(row => ({
      clientId: row.clientID,
      secretId: row.secretID
    }));    
    res.json(spotifyDetails);   
  }
  });
});

//check if user exits and if user does exist performs a check to see if the password the user has entered is correct. 
app.post("/userCheck", (req, res) => {
  const { username, password } = req.body;

  const userdata = 'SELECT username, password FROM users WHERE username = ?';

  connection.query(userdata, [username], (err, results) => {
    if (err) {
      console.error(err);
      res.status(500).send("Error checking user existence");
    } else {
      if (results.length > 0) {
        const storedPassword = results[0].password;

        // Compare the input password with the stored hashed password
        bcrypt.compare(password, storedPassword, (bcryptErr, passwordMatch) => {
          if (bcryptErr) {
            console.error(bcryptErr);
            res.status(500).send("Error comparing passwords");
          } else {
            if (passwordMatch) {
              res.status(200).send("User does exist");
            } else {
              res.status(401).send("Incorrect password");
            }
          }
        });
      } else {
        res.status(404).send("User does not exist");
      }
    }
  });
});

// register a new user if previous call returns User does not exist
app.post("/signup", (req, res) => {
  const { username, password } = req.body;

  // Hash the password before storing it
  bcrypt.hash(password, 10, (hashErr, hashedPassword) => {
    if (hashErr) {
      console.error(hashErr);
      res.status(500).send("Error hashing password");
    } else {
      const query = `INSERT INTO users (username, password) VALUES (?, ?)`;

      // Store the hashed password in the database
      connection.query(query, [username, hashedPassword], (err) => {
        if (err) {
          console.error(err);
          res.status(500).send("Error registering new user");
        } else {
          res.status(200).send("User registered successfully");
        }
      });
    }
  });
});

//upload the details of the quiz to a db for highscore checks
app.post("/upload_score", (req,res) => {
  const {username, gamemode, score, time} = req.body;
  const query = `INSERT INTO game_score (username, gamemode, score, time) VALUES (?, ?, ?, ?)`;

  connection.query(query, [username, gamemode, score, time], (err)=> {
    if (err) {
      console.error(err);
      res.status(500).send("Error uploading details");
    } else {
      res.status(200).send("Upload successful")
    }
  })
});

//fetch the highscore table from db to process and display in quiz 
app.get("/retreive_data",(req,res) => {
  const dataCollect = 'SELECT username,gamemode,score,time FROM game_score';
  connection.query(dataCollect, (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send("Internal Server Error");
    } else {
      const gameDetails = results.map(row => ({
      username: row.username,
      gamemode: row.gamemode,
      score: row.score,
      time: row.time
    }));    
    res.json(gameDetails);   
  }
  });
});


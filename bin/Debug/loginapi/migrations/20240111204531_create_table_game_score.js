/**
 * @param { import("knex").Knex } knex
 * @returns { Promise<void> }
 */
exports.up = function(knex) {
    return knex.schema.createTable('game_score', table => {
        table.increments('id').primary();
        table.string('username').nullable();
        table.string('gamemode').nullable();   
        table.string('score').nullable();
        table.string('time').nullable();   
        table.timestamps(true, true);
      });
};

/**
 * @param { import("knex").Knex } knex
 * @returns { Promise<void> }
 */
exports.down = function(knex) {
    return knex.schema.dropTable('game_score');
};

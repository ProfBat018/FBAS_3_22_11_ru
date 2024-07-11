const { defineConfig } = require("cypress");

module.exports = defineConfig({
  projectId: 'tko6pf',
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});

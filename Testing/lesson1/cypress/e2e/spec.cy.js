describe('template spec', () => {
  it('passes', () => {

    cy.visit('http://localhost:3000');

    cy.contains('Add New Task').click();

    for (let index = 0; index < 10000; index++) {
      cy.get('input[id="taskName"]').type(`Купить BMW M5 CS ${index} раз`);
      cy.get('textarea[id="description"]').type('Не утопленник(желательно)');
      cy.get('input[id="deadline"]').type('2023-12-31');
      
      cy.contains('Add Task').click();

    }

    cy.contains('Cancel').click();

    cy.contains('Show All Tasks').click();

    


  })
})
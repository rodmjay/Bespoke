describe('Person Creation Tests', () => {
  beforeEach(() => {
    // Visit the app before each test
    cy.visit('/');
    
    // Navigate to people page
    cy.contains('span', 'People').click();
  });

  it('should open create form when Create button is clicked', () => {
    // Click the Create button
    cy.contains('button', 'Create').click();
    
    // Verify the creation dialog is displayed
    cy.contains('Create Person').should('be.visible');
    cy.get('#firstName').should('be.visible');
    cy.get('#lastName').should('be.visible');
    cy.get('#email').should('be.visible');
  });

  it('should validate required fields in the create form', () => {
    // Click the Create button
    cy.contains('button', 'Create').click();
    
    // Try to submit without filling required fields
    cy.contains('button', 'Save').click();
    
    // Verify validation errors are displayed
    cy.contains('First name is required').should('be.visible');
    cy.contains('Last name is required').should('be.visible');
    cy.contains('Email is required').should('be.visible');
  });

  it('should create a person successfully', () => {
    // Click the Create button
    cy.contains('button', 'Create').click();
    
    // Fill in the form with test data
    const testName = 'Test' + Date.now();
    cy.get('#firstName').type(testName);
    cy.get('#lastName').type('User');
    cy.get('#email').type(`${testName.toLowerCase()}@example.com`);
    cy.get('#phoneNumber').type('555-123-4567');
    cy.get('#city').type('Seattle');
    
    // Select a state from the dropdown
    cy.get('#stateId').click();
    cy.contains('Washington').click();
    
    // Fill in optional fields
    cy.get('#gitHub').type('https://github.com/testuser');
    
    // Save the new person
    cy.contains('button', 'Save').click();
    
    // Verify success message
    cy.contains('Person created successfully').should('be.visible');
    
    // Verify the new person appears in the list
    cy.contains(testName).should('be.visible');
  });
});

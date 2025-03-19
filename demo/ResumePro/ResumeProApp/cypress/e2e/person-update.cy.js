describe('Person Update Tests', () => {
  beforeEach(() => {
    // Visit the app before each test
    cy.visit('/');
    
    // Navigate to people page
    cy.contains('span', 'People').click();
    
    // Click on the first person in the list (assuming there's at least one)
    cy.get('table tbody tr').first().click();
  });

  it('should open edit form when edit button is clicked', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Verify the edit dialog is displayed
    cy.contains('Edit Person').should('be.visible');
    cy.get('#firstName').should('be.visible');
    cy.get('#lastName').should('be.visible');
  });

  it('should validate required fields in the edit form', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Clear required fields
    cy.get('#firstName').clear();
    cy.get('#lastName').clear();
    cy.get('#email').clear();
    
    // Try to save
    cy.contains('button', 'Save').click();
    
    // Verify validation errors are displayed
    cy.contains('First name is required').should('be.visible');
    cy.contains('Last name is required').should('be.visible');
    cy.contains('Email is required').should('be.visible');
  });

  it('should update person details successfully', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Store original values to verify changes
    let originalName;
    cy.get('#firstName').invoke('val').then(val => {
      originalName = val;
    });
    
    // Update fields
    const newFirstName = 'Updated' + Date.now();
    cy.get('#firstName').clear().type(newFirstName);
    cy.get('#city').clear().type('New City');
    
    // Save changes
    cy.contains('button', 'Save').click();
    
    // Verify success message
    cy.contains('Person updated successfully').should('be.visible');
    
    // Verify the updated information is displayed
    cy.contains(newFirstName).should('be.visible');
    cy.contains('New City').should('be.visible');
  });
});

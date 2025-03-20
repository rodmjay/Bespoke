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
  
  it('should handle invalid email format error', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Enter invalid email format
    cy.get('#email').clear().type('invalid-email-format');
    
    // Save changes
    cy.contains('button', 'Save').click();
    
    // Verify validation error is displayed
    cy.contains('Invalid email format').should('be.visible');
  });
  
  it('should handle server errors when updating person', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Update fields with values that might cause server errors
    const newFirstName = 'Error' + Date.now();
    cy.get('#firstName').clear().type(newFirstName);
    
    // Intercept the API call and force an error response
    cy.intercept('PUT', '**/api/people/*', {
      statusCode: 500,
      body: {
        message: 'Server error occurred while updating person'
      }
    }).as('updatePersonError');
    
    // Save changes
    cy.contains('button', 'Save').click();
    
    // Wait for the intercepted request
    cy.wait('@updatePersonError');
    
    // Verify error message is displayed
    cy.contains('Failed to update person').should('be.visible');
    
    // Verify we're still on the edit form
    cy.contains('Edit Person').should('be.visible');
  });
  
  it('should handle validation errors from server', () => {
    // Click the edit button
    cy.contains('button', 'Edit').click();
    
    // Update fields
    const newFirstName = 'ValidationError' + Date.now();
    cy.get('#firstName').clear().type(newFirstName);
    
    // Intercept the API call and force a validation error response
    cy.intercept('PUT', '**/api/people/*', {
      statusCode: 400,
      body: {
        errors: {
          'Email': ['Email already exists in the system'],
          'PhoneNumber': ['Invalid phone number format']
        }
      }
    }).as('validationError');
    
    // Save changes
    cy.contains('button', 'Save').click();
    
    // Wait for the intercepted request
    cy.wait('@validationError');
    
    // Verify validation errors from server are displayed
    cy.contains('Email already exists in the system').should('be.visible');
    cy.contains('Invalid phone number format').should('be.visible');
    
    // Verify we're still on the edit form
    cy.contains('Edit Person').should('be.visible');
  });
});

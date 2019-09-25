Feature: Home Page
    As a website's user
    I want to validate all Home Page features 

Background: [REQ-UI-01 - REQ-UI-02] - Verify Docler logo and Page Title
    Given an user access Home Page 
    Then Docler Holding logo is present
    And title should be "UI Testing Site"

Scenario: [REQ-UI-03 - REQ-UI-04] - Home button, on Form Page, must navigate to Home Page
    Given an user access Form Page
    And Form Page is displayed 
    When I click on Home button
    Then Home Page is displayed
    And Home button is active

Scenario: [REQ-UI-08 - REQ-UI-04] - UI Testing button, on Form Page, must navigate to Home Page
    Given an user access Form Page
    And Form Page is displayed 
    When I click on UITesting button
    Then Home Page is displayed
    And Home button is active
 
Scenario: [REQ-UI-09] - h1 text is visible 
    Given an user is on Home Page
    Then message "Welcome to the Docler Holding QA Department" in "h1" tag

Scenario: [REQ-UI-10] - p text is visible 
    Given an user is on Home Page
    Then message "This site is dedicated to perform some exercises and demonstrate automated web testing." in "p" tag
        
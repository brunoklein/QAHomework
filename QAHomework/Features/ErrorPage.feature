Feature: Error Page
    As a website's user
    I want to validate all Error Page features
    
Scenario: [REQ-UI-07] - Click on Error button should get a 404 HTTP response code
    Given an user access Home Page
    When I click on Error button
    Then an 404 error code should happen
    
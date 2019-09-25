Feature: Form Page
    As a website's user
    I want to validate all Form Page features

Background: [REQ-UI-01 - REQ-UI-02] - Verify Docler logo and Page Title
    Given an user access Form Page 
    Then Docler Holding logo is present
    And title should be "UI Testing Site"

Scenario: [REQ-UI-05 - REQ-UI-06] - Form button, on Home Page, must navigate to Form Page 
    Given an user access Home Page
    When I click on Form button
    Then Form Page is displayed
    And Form button is active

Scenario: [REQ-UI-11] - One input box and one submit button
    Then user can see one input box
    And one submit button

Scenario Outline: [REQ-UI-12] - Validate the Welcome Message
    Given an user enter the <value>
    When I click on Go button
    Then a message "Hello <value>!" is displayed
    And Docler Holding logo is present
    And title should be "UI Testing Site"

    Examples: 
        |value     |
        |John      |
        |Sophia    |
        |Charlie   |
        |Emily     |
        |Bruno     |
        |São Paulo |

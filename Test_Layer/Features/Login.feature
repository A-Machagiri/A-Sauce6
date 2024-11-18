Feature: Login

Scenario: Successful login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter valid credentials
    Then I should be redirected to the product page

Scenario: Unsuccessful login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter invalid credentials
    Then I should see an error message
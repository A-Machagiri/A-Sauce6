Feature: Login

Scenario: Successful login
  Given I navigate to "{{url}}"
  When I enter valid credentials
  Then I should be redirected to the product page

Scenario: Unsuccessful login
  Given I navigate to "{{url}}"
  When I enter invalid credentials
  Then I should see an error message
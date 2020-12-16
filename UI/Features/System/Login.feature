Feature: Login


  Scenario: user should be able to log in the Superbet page (uid:1abbba98-5a97-4224-ba7d-d2267f7eeb07)
    Given the user is on the page "Superbet"
    When the user tries to log in with valid credentials
    Then the user should be logged in

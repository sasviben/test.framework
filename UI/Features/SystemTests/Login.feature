Feature: Login


  Scenario: the player should be able to log in the Superbet page (uid:b07e1a11-6558-4a5b-8ef6-37bcc1208e24)
    Given the player is on the page "Superbet"
    When the player tries to log in with valid credentials
    Then the player should be logged in
    And the player balance is visible

Feature: Login


  Scenario: the player should be able to log in the Superbet page (uid:faeacdee-4812-49d3-9798-86a50ff5454d)
    Given the player is on the page "SUPERBET"
    When the player tries to log in with valid credentials
    Then the player should be logged in
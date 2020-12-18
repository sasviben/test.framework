Feature: Logout


  Scenario: the online player should be able to logout from the Superbet page (uid:b0cff37c-4662-4798-ab15-c971f4846a4d)
    Given the player is logged in
    When the player tries to logout
    Then the player is logged out

Feature: Logout


  Scenario: the online player should be able to logout from the Superbet page (uid:1d077f62-ab86-41fd-bc6c-ff56c3c0521e)
    Given the player is logged in
    When the player tries to logout
    Then the player is logged out

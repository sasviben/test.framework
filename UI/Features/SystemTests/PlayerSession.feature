Feature: Player Session


  @RULES_automated @regression @acceptance
  Scenario: the player should be able to log in the Superbet page (uid:45bba8d7-836c-41c4-9e37-4064a9ee474b)
    Given the player is on the page "SUPERBET"
    When the player tries to log in with valid credentials
    Then the player should be logged in

  @RULES_automated @regression @acceptance
  Scenario: the online player should be able to logout from the Superbet page (uid:7c59221e-a3cf-467a-9b01-7609816e119d)
    Given the player is logged in
    When the player tries to logout
    Then the player is logged out

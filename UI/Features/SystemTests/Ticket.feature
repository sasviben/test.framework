Feature: Ticket


  @RULES_automation_todo @regression
  Scenario: the agency ticket shouldn't be displayed on the ticket widget (uid:df58c38b-e07e-483d-afae-d2b711e512ff)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" sport "SIMPLE" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased
    But the ticket isn't displayed on the ticket widget
    And the player balance isn't changed

  @RULES_automation_todo @regression
  Scenario: the player should be able to purchase a simple ticket with the "16/16" combination option selected (uid:c49c771e-4533-4526-82d0-b58e35d2f331)
    Given the player has added "16" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "16/16" combinations on the Betslip
    And the player purchases an "AGENCY" sport "SIMPLE" ticket
    Then the "AGENCY" sport "SIMPLE" ticket is purchased

Feature: Ticket


  Scenario: the agency ticket shouldn't be displayed on the ticket widget (uid:0bfc98e4-6f44-4ccb-9118-1fbed882fe93)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased
    But the ticket isn't displayed on the ticket widget
    And the player balance isn't changed

  Scenario: the player should be able to purchase a simple ticket with the "16/16" combination option selected (uid:dd499551-2375-4a6e-83fa-47e2fc845708)
    Given the player has added "16" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "16/16" combinations on the Betslip
    And the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

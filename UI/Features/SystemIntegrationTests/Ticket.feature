Feature: Ticket


  Scenario: the online player should be able to purchase a simple ticket with the "16/16" combination option selected (uid:60b0179c-840c-434a-b39a-afff0ce9b778)
    Given the player is logged in
    And the player has added "16" random "" events to the Betslip
    When the player selects "16/16" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the agency ticket shouldn't be displayed on the ticket widget (uid:8933d495-9846-4e82-bf9f-330f0d9ce088)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased
    But the ticket isn't displayed on the ticket widget
    And the player balance isn't changed

  Scenario: the player should be able to purchase a simple ticket with the "16/16" combination option selected (uid:44d0bc97-4f9f-47dd-ae99-b7b291a5af12)
    Given the player has added "16" random "PREMATCH" events to the Betslip
    When the player selects "16/16" combinations on the Betslip

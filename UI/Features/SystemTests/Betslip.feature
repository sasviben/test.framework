Feature: Betslip


  Scenario: the player shouldn't be able to purchase a ticket with more than 31 events (uid:cec68d90-b931-4357-9cf2-b3c50f22e1e5)
    Given the player is on the page "SPORT"
    When the player adds more than "30" "PREMATCH"events to the Betslip
    Then the "Ai atins numărul maxim de selecții." validation message is displayed on the Betslip
    And the Betslip's purchase button is disabled

  Scenario: the player shouldn't be able to select more than 16 combinations on the system Betslip (uid:42d56b60-2db5-4e5d-aff8-60e1185aa100)
    Given the player is on the page "SPORT"
    When the player adds "17" events to the Betslip
    And the player selects "SYSTEM" ticket on the Betslip
    Then the "1F16/16" combination option is available on the Betslip

Feature: Betslip


  @RULES_automation_todo @regression
  Scenario: the player shouldn't be able to purchase a ticket with more than 31 events (uid:7668cf6f-7e64-4e88-979e-9d8bc94d8b6f)
    Given the player is on the page "SPORT"
    When the player adds more than "30" "PREMATCH"events to the Betslip
    Then the "Ai atins numărul maxim de selecții." validation message is displayed on the Betslip
    And the Betslip's purchase button is disabled

  @RULES_automation_todo @regression
  Scenario: the player shouldn't be able to select more than 16 combinations on the system Betslip (uid:3dd6373b-3572-4627-9bb6-f22d06819235)
    Given the player is on the page "SPORT"
    When the player adds "17" events to the Betslip
    And the player selects "SYSTEM" ticket on the Betslip
    Then the "1F16/16" combination option is available on the Betslip

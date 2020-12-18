Feature: Betslip


  Scenario: the player shouldn't be able to purchase a ticket with more than 31 events (uid:6e032347-631e-4583-82cd-1bf587fe39f2)
    Given the player is on the page "SPORT"
    When the player adds more than "30" "PREMATCH"events to the Betslip
    Then the "Ai atins numărul maxim de selecții." validation message is displayed on the Betslip
    And the Betslip's purchase button is disabled

  Scenario: the player shouldn't be able to select more than 16 combinations on the system Betslip (uid:0958f478-7a2e-4937-a3ea-17585adb5c04)
    Given the player is on the page "SPORT"
    When the player adds "17" events to the Betslip
    And the player selects "SYSTEM" ticket on the Betslip
    Then the "1F16/16" combination option is available on the Betslip

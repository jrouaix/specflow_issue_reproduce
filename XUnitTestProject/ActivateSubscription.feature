Feature: ActivateSubscription

A short summary of the feature

Scenario: HTTP 202 - Happy case
	Given requests body "IS" valid
    And subscription "IS" exists
	When activate Subscription is called
	Then the REST API HTTP status must be 202
    And the actor "IS" called

Scenario: HTTP 404 - Subscirption not found
	Given requests body "IS" valid
    And subscription "IS_NOT" exists
	When activate Subscription is called
	Then the REST API HTTP status must be 404
    And the actor "IS" called
	
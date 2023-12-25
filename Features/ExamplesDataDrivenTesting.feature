Feature: Examples Data Driven Testing

@DataDrivenExample
Scenario Outline:  Examples Data Driven Testing
	Given Open the browser
	When Enter the URL
	Then Search with <searchKey>
	Examples: 
	| searchKey  |
	| Dbiz Solution |
	| Dbiz Solution Career |

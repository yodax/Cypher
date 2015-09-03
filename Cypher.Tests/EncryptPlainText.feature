Feature: Encrypt Plain Text
	
	As a privacy nut I would like to encrypt text in the worst possible way by using a substitution cypher

	The cypher will replace each letter with another letter. Each letter will be used exactly once.

	My plain and text will be case insensitive and punctuation marks will not be encrypted

Scenario: A simple plain text using all letters from the alphabet
	Given the plain text
	"""
	the quick brown fox jumps over the lazy dog
	"""
	When I encrypt the text using the following letter substitution
	| Plain text letter | Cypher text letter |
	| A                 | B                  |
	| B                 | C                  |
	| C                 | D                  |
	| D                 | E                  |
	| E                 | F                  |
	| F                 | G                  |
	| G                 | H                  |
	| H                 | I                  |
	| I                 | J                  |
	| J                 | K                  |
	| K                 | L                  |
	| L                 | M                  |
	| M                 | N                  |
	| N                 | O                  |
	| O                 | P                  |
	| P                 | Q                  |
	| Q                 | R                  |
	| R                 | S                  |
	| S                 | T                  |
	| T                 | U                  |
	| U                 | V                  |
	| V                 | W                  |
	| W                 | X                  |
	| X                 | Y                  |
	| Y                 | Z                  |
	| Z                 | A                  |
	Then the cypher text should be
	"""
	UIF RVJDL CSPXO GPY KVNQT PWFS UIF MBAZ EPH
	"""
	
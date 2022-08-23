# CSharpCoding
Based on the requirement wrote the logic

Following are the task instructions:

Program to Group a list of References and find the next Reference for each reference

Write a .Net Core Console Application that accepts a list of strings containing data in the following formats:

An item that starts with a letter or combination of letters and numbers, but always ends with a number (E.g., “S3126112345”, “SP39263456”)
An item that contains only numbers (E.g., “250783579”, “391543579”)
An item that contains only letters, or ends always ends with letter(s) (E.g., “SPREFERENCE”, “SPREF123XYZ”)
Sample List:

{“S1000112345”, “SP21003456”, “SP39263456”, “120013579VA”, “SP00003456”, “S3126112345”, “SPREFERENCE”, “XYZ250783579”, “391543579”, “130013579”}

Note: The list given above is just a sample, and the program should cater to any kind of list containing any combination of strings.

The program should do the following:

1.     Ignore the items that contain only letters or ends with letter(s)

2.     For the items that contain combination of letters and numbers (but end with number) do the following:

a)               Split the string such that 2nd part contains only trailing numbers, and the 1st part contains the remaining string:

E.g.,

“SP39263456” should be split into “SP” and “39263456”

“SR12AB25341” should be split into “SR12AB” and “25341”

 

b)               Group these strings based on their 1st part of the split.

E.g., all the strings beginning with “SP” should fall in one group,

all strings beginning with “SREF” should fall in one group, and so on.

3.     Find the next logical sequence for each item in the list (except for those items which contain only letters or end with letter(s)):

E.g.

“S1000112345” à “S1000112346”

“SP39A263456” à “SP39A263457”

“120013579” à “120013580” and so on.

#Basic Guidlines
1. Each Class that needs testing gets its own testing class in its own file which will be named FooTest.cs where Foo is the class being tested
2. Test Methods are to have very descriptive names as length doesn’t matter since they won’t be called elsewhere and when tests are run all it shows is the tests name
 - It is easier to figure out that foo is returning a null and why when you see what failed is checkOutputOfFooIfPassedNull rather than FooTest04
3. The file called [ClassBeingTested]Test.cs is an example of how it should look as well as a container for any test methods that needed to be reaserched.
 - An example of this is it contains a test showing how to check for an expected exception seeing as that doesn’t use assert
---
#Style Guidlines
###These are to be used until a set style is decided upon then they will be reviewed and updated and will then overrule the generic rules of style as tests may need special rules
1. In any instance where you could go without using braces "{}" such as an "if" with only one outcome you **Will** use them anyway
2. Braces "{}" are to start on the originating line and end on an emtpy line Ex:
'''
If (b) {
	b = false;
}
'''
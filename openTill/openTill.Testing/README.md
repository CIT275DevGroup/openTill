#Basic Guidlines
- Each Class that needs testing gets its own testing class in its own file which will be named FooTest.cs where Foo is the class being tested
- Test Methods are to have very descriptive names as length doesn’t matter since they won’t be called elsewhere and when tests are run all it shows is the tests name
 - It is easier to figure out that foo is returning a null and why when you see what failed is checkOutputOfFooIfPassedNull rather than FooTest04
- The file called [ClassBeingTested]Test.cs is an example of how it should look as well as a container for any test methods that needed to be reaserched.
 - An example of this is it contains a test showing how to check for an expected exception seeing as that doesn’t use assert

#Style Guidlines
####These are to be used until a set style is decided upon then they will be reviewed and updated and will then overrule the generic rules of style as tests may need special rules
- In any instance where you could go without using braces "{}" such as an "if" with only one outcome you **Will** use them anyway
- Braces "{}" are to start on the originating line and end on an emtpy line
 - The exception to this rule is if you are fully stating an array in which case it starts right at the start and ends at the last variable
```
bool[] b = new bool[2] { true, false };
If (b[0]) {
	b[0] = false;
}
else {
	b[0] = true;
}
```
- Variables will be fully named, no shortcuts such as calling your int 'i' and use lower camel case
 - An exception to the not using short variable names is with "for" loops where you may use something like i for an int
- Always set your veriables to something when you create them
 - it is a lot harder to track down why your integer is some random number when you let the system set it to whatever it wants
```
int exampleTestInt = 0;
for (int i = 0; i < 10; i++) {
	exampleTestInt++;
}
```
- Methods will be descriptively named and use upper camel case
 - If you can't tell what the method is doing by its name you either need to name it better or you need to split it into more tests
- All test methods are public and you will state as much, no leaving it off
```
[TestMethod]
public void checkingThatTrueEqualsTrue() {
	Assert.AreEqual(true, true);
}
```
- openTill.Testing should only contain tests
 - if you can't do it with just that your testing the wrong thing or something needs to be added to the code itself
- Tests methods should only be asserting one thing unless atleast one other person agrees you need to assert multiple things
 - Having to duplicate code is not a reason for having multiple asserts to a method
 - If you use multiple asserts then comments explaining exactly why it they are needed is required
 - I [Zak T] Reserve the right to change any test with multiple asserts so as to make it so there are not irrespective of my current job
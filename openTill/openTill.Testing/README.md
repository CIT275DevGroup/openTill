1. Each Class that needs testing gets its own testing class which will be named FooTest.cs where Foo is the class being tested
2. Test Methods are to have very descriptive names as length doesn’t matter since they won’t be called elsewhere and when tests are run all it shows is the tests name
 - It is easier to figure out that foo is returning a null and why when what you see failed is checkOutputOfFooIfPassedNull rather than FooTest04
3. The file called [ClassBeingTested]Test.cs is an example of how it should look as well as a container for any tests that needed to be reaserched.
 - An example of this is it contains a test showing how to check for an expected exception seeing as that doesn’t use assert
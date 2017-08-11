using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestedClass = UnitTest_MilitaryRecruitment;

namespace UnitTest_MilitaryRecruitment
{
    /// <summary>
    /// Desription for the TestFixture_UnitTest_MilitaryRecruitment
    /// </summary>
    [TestClass]
    public class TestFixture_UnitTest_MilitaryRecruitment

    {
       public TestFixture_UnitTest_MilitaryRecruitment()
       {
           // No constructor, use the Setup and Teardown methods instead
       }
                #region ########## Start Code ##########
        private TestContext testContextInstance;
        /// <summary>
        /// gets or sets the test content which provide 
        /// information and functionality for the current test run
        /// </summary>
        public TestContext TestContext
        {
            get{
                return testContextInstance;
            }
            set{
                testContextInstance = value;
            }
        }
                #endregion

                #region ############## Additional Test Attributes  ####################
        [TestInitialize]

        public void TestInitialize()
        {
            // a new instances of tested class is created for every test case.

            TestedClass = new TestedClass();
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestedClass = null;
        }
               #endregion


                #region ####################### Add operation Test case Save Military Recruitment ############################
         [TestMethod]
        public void Add_Test_SaveMilitaryRecruitmentData0and0_EvaluatesTo0();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_SaveMilitaryRecruitmentData0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_SaveMilitaryRecruitmentData1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //---------------------------------------------------------------------------------------------------------------
#endregion
                #region####################### Add operation Test case Load Military Recruitment ############################
        [TestMethod]
        public void Add_Test_LoadMilitaryRecruitmentData0and0_EvaluatesTo0();
     
        {
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);   
        }
    //---------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_LoadMilitaryRecruitmentData0and1_EvaluatesTo1();
     
        {
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);   
        }
    //-----------------------------------------------------------------------------------------------------------------
    [TestMethod]
        public void Add_Test_LoadMilitaryRecruitmentData1and1_EvaluatesTo2();
     
        {
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);   
        }
    //-----------------------------------------------------------------------------------------------------------------
#endregion
                #region####################### Add operation Test case Successful Applicant ############################
      [TestMethod]
        public void Add_Test_SucessfulApplicant0and0_EvaluatesTo0();
     
        { 
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_SucessfulApplicant0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_SucessfulApplicant1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
            
             
        }
#endregion
                #region####################### Add operation Test case Successful Applicant ############################
          [TestMethod]
        public void Add_Test_SetForceServiceMark0and0_EvaluatesTo0();
        {
             
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_SetForceServiceMark0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_SetForceServiceMark1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
           
#endregion
                #region####################### Add_Test_UnenrolApplicant ############################
        [TestMethod]
        public void Add_Test_UnenrolApplicant0and0_EvaluatesTo0();
        {
             
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_UnenrolApplicant0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_UnenrolApplicant1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
            
          
    #endregion
                #region####################### Add_Test_EnrolApplicant ############################
       
         
           [TestMethod]
        public void Add_Test_EnrolApplicant0and0_EvaluatesTo0();
        {
             
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_EnrolApplicant0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_EnrolApplicant1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
            
#endregion
                #region####################### Add_Test_AddForceService ############################
   
        
           [TestMethod]
        public void Add_Test_AddForceService0and0_EvaluatesTo0();
        {
             
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_AddForceService0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_AddForceService1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
            
          
#endregion
                #region####################### Add_Test_AddForceService ############################
   
                  [TestMethod]
        public void Add_Test_AddApplicant0and0_EvaluatesTo0();
        {
             
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 0;
         Var expectedResult = 0;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //----------------------------------------------------------------------------------------------
      [TestMethod]
        public void Add_Test_AddApplicant0and1_EvaluatesTo1();
     
        {
            
            // Arrange
         Var testArgument1 = 0;
         Var testArgument2 = 1;
         Var expectedResult = 1;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
    //--------------------------------------------------------------------------------------------------------
     [TestMethod]
        public void Add_Test_AddApplicant1and1_EvaluatesTo2();
     
        {
            
            // Arrange
         Var testArgument1 = 1;
         Var testArgument2 = 1;
         Var expectedResult = 2;

        //Act
        Var actualResult = TestedClass.Add(testArgument1, testArgument2);

        // Assert
        Var failMessage = String.Format(@"{0} + {1} evaluates to {2}, actual test result was {3}", testArgument1, testArgument2, ExpectedResult, actualResult);
        Assert.AreEqual(expectedResult, actualResult, failMessage);
             
        }
            
}
                #endregion 

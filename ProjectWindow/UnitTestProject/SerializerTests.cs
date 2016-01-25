using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers.Util;
using Models;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class SerializerTests
    {
        private ProjectSerializer serializer;
        private string testPath;

        [TestInitialize]
        public void Init()
        {
            testPath = @"C:\projectSquared\test\";
            serializer = new ProjectSerializer(testPath);
        }

        [TestMethod]
        public void SaveMember()
        {
            Member toSave = new Member("memTest1", "TestSave Member");
            string filename = "bareMember.xml";
            //serializer.Save(toSave, filename);
            CustomXmlSerializer.Serialize(toSave, testPath, filename);

            Assert.IsTrue(File.Exists(testPath + filename), "File: " + filename + " not written to path " + testPath);

            toSave.AddRole(MemberRole.Creator);
            toSave.AddRole(MemberRole.Manager);

            toSave.ContactInfo = new ContactInfo("conInf1", "someEmail@domain.com", "12345678");

            filename = "filledMember.xml";
            //serializer.Save(toSave, filename);
            CustomXmlSerializer.Serialize(toSave, testPath, filename);

            Assert.IsTrue(File.Exists(testPath + filename), "File: " + filename + " not written to path " + testPath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using AccelByte.Sdk.Sample.Cli;

namespace AccelByte.Sdk.Tests
{
    public class SampleCLIAppTests
    {

        [Test]
        [TestCase(TestName = "Empty Parameter")]        
        public void NoParameterCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.Parameters.Count == 0);
                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == String.Empty);
                Assert.True(cArgs.LoginPassword == String.Empty);
            });
        }

        [Test]
        [TestCase(new object[] { "--namespace", "test" }, TestName = "Single Parameter")]
        public void SingleParameterCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.Parameters.Count == 1);
                Assert.True(cArgs.Parameters.ContainsKey("namespace"));
                Assert.True(cArgs.Parameters["namespace"] == "test");
                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == String.Empty);
                Assert.True(cArgs.LoginPassword == String.Empty);
            });
        }

        [Test]
        [TestCase(new object[] { "--namespace", "test", "--action", "test1", "--param", "test2" }, TestName = "Multiple Parameter")]
        public void MultipleParameterCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.Parameters.Count > 1);
                Assert.True(cArgs.Parameters.ContainsKey("namespace")
                    && cArgs.Parameters.ContainsKey("action")
                    && cArgs.Parameters.ContainsKey("param"));

                Assert.True((cArgs.Parameters["namespace"] == "test")
                    && (cArgs.Parameters["action"] == "test1")
                    && (cArgs.Parameters["param"] == "test2"));
                
                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == String.Empty);
                Assert.True(cArgs.LoginPassword == String.Empty);
            });
        }

        [Test]
        [TestCase(new object[] { "--namespace", "test", "--action", "--param", "test2" }, TestName = "Multiple Parameter With Empty Value")]
        public void MultipleParameterWithEmptyValueCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.Parameters.Count > 1);
                Assert.True(cArgs.Parameters.ContainsKey("namespace")
                    && cArgs.Parameters.ContainsKey("action")
                    && cArgs.Parameters.ContainsKey("param"));

                Assert.True((cArgs.Parameters["namespace"] == "test")
                    && (cArgs.Parameters["action"] == "")
                    && (cArgs.Parameters["param"] == "test2"));

                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == String.Empty);
                Assert.True(cArgs.LoginPassword == String.Empty);
            });
        }

        [Test]
        [TestCase(new object[] { "--namespace", "test", "--action", "test1", "--param", "test2", "--user", "user", "--pass", "pass" }, TestName = "Multiple Parameter with Login Info")]
        public void MultipleParameterWithLoginInfoCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.Parameters.Count > 1);
                Assert.True(cArgs.Parameters.ContainsKey("namespace")
                    && cArgs.Parameters.ContainsKey("action")
                    && cArgs.Parameters.ContainsKey("param"));

                Assert.True((cArgs.Parameters["namespace"] == "test")
                    && (cArgs.Parameters["action"] == "test1")
                    && (cArgs.Parameters["param"] == "test2"));

                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == "user");
                Assert.True(cArgs.LoginPassword == "pass");                
            });
        }

        [Test]
        [TestCase(new object[] { "--op", "login", "--user", "user", "--pass", "pass" }, TestName = "Login operation with Login Info")]
        public void LoginInfoAndOpLoginCommandArgumentTest(params string[] args)
        {
            CommandArguments cArgs = new CommandArguments(args);

            Assert.Multiple(() =>
            {
                Assert.True(cArgs.OperationName == "login");
                Assert.True(cArgs.LoginType == CommandArguments.LoginTypeUser);
                Assert.True(cArgs.RequestFileContent == String.Empty);
                Assert.True(cArgs.LoginUsername == "user");
                Assert.True(cArgs.LoginPassword == "pass");
            });
        }

        [Test]
        [TestCase(new object[] { "--op", "login", "--user", "--pass", "pass" }, TestName = "Login Info with Empty Username")]
        public void LoginInfoWithEmptyUsernameCommandArgumentTest(params string[] args)
        {
            Assert.Throws<CommandArgumentException>(() =>
            {
                CommandArguments cArgs = new CommandArguments(args);
                Assert.True(cArgs.LoginUsername == "user");
                Assert.True(cArgs.LoginPassword == "pass");
            });
        }

        [Test]
        [TestCase(new object[] { "--op", "login", "--user", "user", "--pass" }, TestName = "Login Info with Empty Password")]
        public void LoginInfoWithEmptyPasswordCommandArgumentTest(params string[] args)
        {
            Assert.Throws<CommandArgumentException>(() =>
            {
                CommandArguments cArgs = new CommandArguments(args);
                Assert.True(cArgs.LoginUsername == "user");
                Assert.True(cArgs.LoginPassword == "pass");
            });
        }
    }
}

/* 
 * Merchant API
 *
 * Up Bank API Initial build
 *
 * OpenAPI spec version: 2020-09-20
 * 
 */

using System;
using System.Collections.Generic;

using NUnit.Framework;
using Newtonsoft.Json;

using UpBankApi.Api;
using UpBankApi.Client;
using UpBankApi.Model;

namespace UpBankApi.Test
{
    /// <summary>
    ///  Class for testing Accounts
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BackingApiTests
    {

        #region Test Setup 

        // TODO uncomment below to declare an instance variable for AccountList
        string apiToken;
        string clientString;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            apiToken = "up:yeah:<enter your token>";
            clientString = "https://api.up.com.au/api/v1";
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        #endregion

        #region Test Routines

        #region Accounts

        /// <summary>
        /// Test Get an AccountList
        /// </summary>
        public AccountList GetAllAccounts()
        {
            AccountList accountList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            accountList = bankingApi.AccountList(pageSize);

            return accountList;
        }

        /// <summary>
        /// Test Get an Account
        /// </summary>
        public Account GetAccount(string Id)
        {
            Account account = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            account = bankingApi.AccountGet(Id);

            return account;
        }

        /// <summary>
        /// Test Get an Account by name
        /// </summary>
        public Account GetAccountByName(string name = null)
        {
            AccountList accountsList = null;
            Account account = null;

            accountsList = GetAllAccounts();

            if (accountsList != null && accountsList.Data.Count > 0)
            {
                foreach (var item in accountsList.Data)
                {
                    account = GetAccount(item.Id);
                    if (account.Data.Attributes.DisplayName == name)
                    {
                        return account;
                    }
                }
            }

            return account;
        }

        #endregion

        #region Transactions

        /// <summary>
        /// Test Get a TransactionList
        /// </summary>
        public TransactionList GetAllTransactions()
        {
            TransactionList transactionList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            transactionList = bankingApi.TransactionList(pageSize);

            return transactionList;
        }

        /// <summary>
        /// Test Get a Transaction
        /// </summary>
        public Transaction GetTransaction(string id = null)
        {
            Transaction transaction = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            transaction = bankingApi.TransactionGet(id);

            return transaction;
        }

        /// <summary>
        /// Test Get all Transactions for an Account
        /// </summary>
        public TransactionList GetAllTransactionsForAccount(string id = null)
        {
            TransactionList transactionList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            transactionList = bankingApi.TransactionListForAccount(id, pageSize);

            return transactionList;
        }

        #endregion

        #region Tags

        /// <summary>
        /// Test Get a TagList
        /// </summary>
        public TagList GetAllTags()
        {
            TagList tagList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            tagList = bankingApi.TagList(pageSize);

            return tagList;
        }

        /// <summary>
        /// Test Add a tag to a Transaction
        /// </summary>
        public Transaction TransactionAddTag(string id = null)
        {
            Transaction transaction = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            var tags = GetAllTags();

            DataObject tagInputDataObject1 = new DataObject(tags.Data[0].Type, tags.Data[0].Id);
            DataObject tagInputDataObject2 = new DataObject(tags.Data[1].Type, tags.Data[1].Id);
            List<DataObject> tagInputList = new List<DataObject>();
            tagInputList.Add(tagInputDataObject1);
            tagInputList.Add(tagInputDataObject2);
            TagInput tagInput = new TagInput(tagInputList);
            object Data = tagInput.ToJson();

            bankingApi.TransactionAddTag(id, Data);

            transaction = GetTransaction(id);

            return transaction;
        }

        /// <summary>
        /// Test Delete a tag from a Transaction
        /// </summary>
        public Transaction TransactionDeleteTag(string id = null)
        {
            Transaction transaction = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            var tags = GetAllTags();

            DataObject tagInputDataObject1 = new DataObject(tags.Data[0].Type, tags.Data[0].Id);
            DataObject tagInputDataObject2 = new DataObject(tags.Data[1].Type, tags.Data[1].Id);
            List<DataObject> tagInputList = new List<DataObject>();
            tagInputList.Add(tagInputDataObject1);
            tagInputList.Add(tagInputDataObject2);
            TagInput tagInput = new TagInput(tagInputList);
            object Data = tagInput.ToJson();

            bankingApi.TransactionDeleteTag(id, Data);

            transaction = GetTransaction(id);

            return transaction;
        }

        #endregion

        #region Categories

        /// <summary>
        /// Test Get a CategoryList
        /// </summary>
        public CategoryList GetAllCategories()
        {
            CategoryList categoryList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            categoryList = bankingApi.CategoryList(pageSize);

            return categoryList;
        }

        /// <summary>
        /// Test Get a Category
        /// </summary>
        public Category GetCategory(string id = null)
        {
            Category Category = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            Category = bankingApi.CategoryGet(id);

            return Category;
        }

        #endregion

        #region Webhooks

        /// <summary>
        /// Test Get a WebhookList
        /// </summary>
        public WebhookList GetAllWebhooks()
        {
            WebhookList webhookList = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            webhookList = bankingApi.WebhooksList(pageSize);

            return webhookList;
        }

        /// <summary>
        /// Test Get a Webhook
        /// </summary>
        public Webhook GetWebhook(string id = null)
        {
            Webhook webhook = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            webhook = bankingApi.WebhookGet(id);

            return webhook;
        }

        /// <summary>
        /// Test Create a Webhook
        /// </summary>
        public Webhook CreateWebhook()
        {
            Webhook webhook = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            WebhookInputAttributes webhookInputAttributes = new WebhookInputAttributes("https://v43demo.selectsystems.com.au/mollie/webhook/5042", "Example webhook");
            webhook = bankingApi.WebhookCreate(webhookInputAttributes);

            return webhook;
        }

        /// <summary>
        /// Test Delete a Webhook
        /// </summary>
        public Webhook DeleteWebhook(string id = null)
        {
            Webhook webhook = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            webhook = bankingApi.WebhookDelete(id);

            return webhook;
        }

        /// <summary>
        /// Test Ping a Webhook
        /// </summary>
        public WebhookEvent PingWebhook(string id = null)
        {
            WebhookEvent webhookEvent = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            webhookEvent = bankingApi.WebhookPing(id);

            return webhookEvent;
        }

        /// <summary>
        /// Test Get a WebhookDeliveryLog
        /// </summary>
        public WebhookDeliveryLog GetWebhookDeliveryLog(string id = null)
        {
            WebhookDeliveryLog webhookDeliveryLog = null;

            var bankingApi = new BankingApi(clientString, apiToken);

            int pageSize = 10;
            webhookDeliveryLog = bankingApi.WebhookGetDeliveryLog(id, pageSize);

            return webhookDeliveryLog;
        }

        #endregion

        #endregion

        #region Test Instances

        /// <summary>
        /// Test an instance of Pingdata
        /// </summary>
        [Test]
        public void InstanceTestPingdata()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account

            Meta meta = new Meta("74033c80-07e6-4a77-9af6-47067b32acc5", "⚡️");

            Pingdata instance = new Pingdata(meta);

            Assert.IsInstanceOf<Pingdata>(instance, "variable 'instance' is Pingdata");
        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Test]
        public void InstanceTestAccountList()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);
            RelationshipTransactions transactions = new RelationshipTransactions(relatedLinks);
            AccountRelationships relationships = new AccountRelationships(transactions);

            var jRelationships = relationships.ToJson();

            decimal value1 = 1.0M;
            MoneyObject balance1 = new MoneyObject("AUD", value1, 100);
            decimal value2 = 2.0M;
            MoneyObject balance2 = new MoneyObject("AUD", value2, 200);

            DateTime timeNow = DateTime.Now;

            AccountAttributes attributes1 = new AccountAttributes("Up Account", AccountAttributes.AccountTypeEnum.TRANSACTIONAL, balance1, timeNow);

            AccountAttributes attributes2 = new AccountAttributes("Savings Account", AccountAttributes.AccountTypeEnum.SAVER, balance2, timeNow);

            ResourceLinks selfLink = new ResourceLinks("https://api.up.com.au/api/self");

            AccountResource data1 = new AccountResource("accounts", "3b7e6d5e-9216-4763-9d01-a7245b83ede5", attributes1, relationships, selfLink);

            var jData1 = data1.ToJson();

            AccountResource data2 = new AccountResource("accounts", "3b7e6d5e-9216-4763-9d01-a7245b83ede5", attributes2, relationships, selfLink);

            var jData2 = data2.ToJson();

            var accountsReseorceList = new List<AccountResource>();

            accountsReseorceList.Add(data1);
            accountsReseorceList.Add(data2);

            foreach (var arl in accountsReseorceList)
            {
                var jAccountsReseorceList = arl.ToJson();
            }

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            AccountList instance = new AccountList(accountsReseorceList, links);

            var jLinks = links.ToJson();

            var result = instance.ToJson();

            var json = JsonConvert.DeserializeObject<AccountList>(result);

            Assert.IsInstanceOf<AccountList>(instance, "variable 'instance' is an AccountList");

        }

        /// <summary>
        /// Test an instance of TransactionList
        /// </summary>
        [Test]
        public void InstanceTestTransactionList()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);
            RelationshipTransactions transactions = new RelationshipTransactions(relatedLinks);
            AccountRelationships relationships = new AccountRelationships(transactions);

            var jRelationships = relationships.ToJson();

            decimal value1 = 1.0M;
            MoneyObject balance1 = new MoneyObject("AUD", value1, 100);
            decimal value2 = 2.0M;
            MoneyObject balance2 = new MoneyObject("AUD", value2, 200);

            DateTime timeNow = DateTime.Now;

            MoneyObject moneyObject = new MoneyObject("AUD", 1.0M, 1);

            HoldInfoObject holdInfoObject = new HoldInfoObject(moneyObject, moneyObject);

            RoundUpObject roundUpObject = new RoundUpObject(moneyObject, moneyObject);

            CashbackObject cashbackObject = new CashbackObject("description", moneyObject);

            MoneyObject accountObject = new MoneyObject("AUD", 1.0M, 1);

            MoneyObject foreignAmount = new MoneyObject("AUD", 1.0M, 1);

            TransactionAttributes attributes1 = new TransactionAttributes(TransactionAttributes.TransactionStatusEnum.SETTLED, "Raw Test"
                , "David Taylor", "Money for the pizzas last night.", holdInfoObject, roundUpObject, cashbackObject, accountObject, foreignAmount, timeNow, timeNow);

            TransactionAttributes attributes2 = new TransactionAttributes(TransactionAttributes.TransactionStatusEnum.SETTLED, "Raw Test"
                , "Taylor David", "Money for the pizzas last night.", holdInfoObject, roundUpObject, cashbackObject, accountObject, foreignAmount, timeNow, timeNow);

            ResourceLinks selfLink = new ResourceLinks("https://api.up.com.au/api/self");

            DataObject accountDataObject = new DataObject("Account", "08901517-1987-4e5d-8032-b313a939e3e8");
            AccountObject accountRelationshipObject = new AccountObject(accountDataObject);

            DataObject categroyDataObject = new DataObject("Category", "08901517-1987-4e5d-8032-b313a939e3e8");
            CategoryObject categroyRelationshipObject = new CategoryObject(categroyDataObject);

            DataObject parentCategroyDataObject = new DataObject("parentCategory", "08901517-1987-4e5d-8032-b313a939e3e8");
            ParentCategoryObject parentCategroyRelationshipObject = new ParentCategoryObject(parentCategroyDataObject);

            DataObject tagDataObject1 = new DataObject("Tag", "08901517-1987-4e5d-8032-b313a939e3e8");

            DataObject tagDataObject2 = new DataObject(); // Test Null values

            var tagDataObjectList = new List<DataObject>();

            tagDataObjectList.Add(tagDataObject1);
            tagDataObjectList.Add(tagDataObject2);

            TagObject tagRelationshipObject = new TagObject(tagDataObjectList);

            TransactionRelationships transactionRelationship = new TransactionRelationships(accountRelationshipObject, categroyRelationshipObject, parentCategroyRelationshipObject, tagRelationshipObject);

            TransactionResource data1 = new TransactionResource("transactions", "08901517-1987-4e5d-8032-b313a939e3e8", attributes1, transactionRelationship, selfLink);

            var jData1 = data1.ToJson();

            TransactionResource data2 = new TransactionResource("transactions", "08901517-1987-4e5d-8032-b313a939e3e8", attributes2, transactionRelationship, selfLink);

            var jData2 = data2.ToJson();

            var transactionReseorceList = new List<TransactionResource>();

            transactionReseorceList.Add(data1);
            transactionReseorceList.Add(data2);

            foreach (var arl in transactionReseorceList)
            {
                var jTransactionReseorceList = arl.ToJson();
            }

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            TransactionList instance = new TransactionList(transactionReseorceList, links);

            var jLinks = links.ToJson();

            var result = instance.ToJson();

            var json = JsonConvert.DeserializeObject<TransactionList>(result);

            Assert.IsInstanceOf<TransactionList>(instance, "variable 'instance' is an TransactionList");

        }

        /// <summary>
        /// Test an instance of TagList
        /// </summary>
        [Test]
        public void InstanceTestTagList()
        {
            // TODO uncomment below to test "IsInstanceOfType" TagList

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);
            RelationshipTransactions transactions = new RelationshipTransactions(relatedLinks);
            TagRelationships relationships = new TagRelationships(transactions);

            var jRelationships = relationships.ToJson();

            ResourceLinks selfLink = new ResourceLinks("https://api.up.com.au/api/self");

            TagResource data1 = new TagResource("Tags", "3b7e6d5e-9216-4763-9d01-a7245b83ede5", relationships, selfLink);

            var jData1 = data1.ToJson();

            TagResource data2 = new TagResource("Tags", "3b7e6d5e-9216-4763-9d01-a7245b83ede5", relationships, selfLink);

            var jData2 = data2.ToJson();

            var tagReseorceList = new List<TagResource>();

            tagReseorceList.Add(data1);
            tagReseorceList.Add(data2);

            foreach (var arl in tagReseorceList)
            {
                var jTagReseorceList = arl.ToJson();
            }

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            var jLinks = links.ToJson();

            TagList instance = new TagList(tagReseorceList, links);

            var result = instance.ToJson();

            var json = JsonConvert.DeserializeObject<TagList>(result);

            Assert.IsInstanceOf<TagList>(instance, "variable 'instance' is a TagList");

        }

        /// <summary>
        /// Test an instance of CategoryList
        /// </summary>
        [Test]
        public void InstanceTestCategoryList()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);

            DataObject parentDataObject = new DataObject("categories", "good-life");

            DataObject childrenDataObject1 = new DataObject("categories", "good-life");

            DataObject childrenDataObject2 = new DataObject();

            var childrenDataObjectList = new List<DataObject>();

            childrenDataObjectList.Add(childrenDataObject1);
            childrenDataObjectList.Add(childrenDataObject2);

            ParentObject parent = new ParentObject(parentDataObject, relatedLinks);

            var jParent = parent.ToJson();

            ChildrenObject children = new ChildrenObject(childrenDataObjectList, relatedLinks);

            var jChildren = children.ToJson();

            CategoryRelationships relationships = new CategoryRelationships(parent, children);

            var jRelationships = relationships.ToJson();

            CategoryAttributes attributes1 = new CategoryAttributes("Category1 \u0026 Last");

            CategoryAttributes attributes2 = new CategoryAttributes("Category2 \u0026 Last");

            ResourceLinks selfLink = new ResourceLinks("https://api.up.com.au/api/self");

            CategoryResource data1 = new CategoryResource("categories", "hobbies", attributes1, relationships, selfLink);

            var jData1 = data1.ToJson();

            CategoryResource data2 = new CategoryResource("categories", "coffee", attributes2, relationships, selfLink);

            var jData2 = data2.ToJson();

            var categoryReseorceList = new List<CategoryResource>();

            categoryReseorceList.Add(data1);
            categoryReseorceList.Add(data2);

            foreach (var arl in categoryReseorceList)
            {
                var jCategorytReseorceList = arl.ToJson();
            }

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            var jLinks = links.ToJson();

            CategoryList instance = new CategoryList(categoryReseorceList, links);

            var result = instance.ToJson();

            var jCategoryList = JsonConvert.DeserializeObject<CategoryList>(result);

            Assert.IsInstanceOf<CategoryList>(instance, "variable 'instance' is an CategoryList");

        }

        /// <summary>
        /// Test an instance of WebhookList
        /// </summary>
        [Test]
        public void InstanceTestWebhookList()
        {
            // TODO uncomment below to test "IsInstanceOfType" WebhookList

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);
            WebhookLogs logs = new WebhookLogs(relatedLinks);
            WebhookRelationships relationships = new WebhookRelationships(logs);

            var jRelationships = relationships.ToJson();

            DateTime timeNow = DateTime.Now;

            WebhookAttributes attributes1 = new WebhookAttributes("http://example.com/webhook-1", "Webhook number 1", "4c47e957-c9e4-4968-8e6f-943246560ca5", timeNow);

            WebhookAttributes attributes2 = new WebhookAttributes("http://example.com/webhook-2", "Webhook number 2", "4c47e957-c9e4-4968-8e6f-943246560ca5", timeNow);

            ResourceLinks selfLink = new ResourceLinks("https://api.up.com.au/api/self");

            WebhookResource data1 = new WebhookResource("webhooks", "4c47e957-c9e4-4968-8e6f-943246560ca5", attributes1, relationships, selfLink);

            var jData1 = data1.ToJson();

            WebhookResource data2 = new WebhookResource("webhooks", "4c47e957-c9e4-4968-8e6f-943246560ca5", attributes2, relationships, selfLink);

            var jData2 = data2.ToJson();

            var webhookReseorceList = new List<WebhookResource>();

            webhookReseorceList.Add(data1);
            webhookReseorceList.Add(data2);

            foreach (var arl in webhookReseorceList)
            {
                var jWebhookReseorceList = arl.ToJson();
            }

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            WebhookList instance = new WebhookList(webhookReseorceList, links);

            Assert.IsInstanceOf<WebhookList>(instance, "variable 'instance' is a TagList");
        }

        /// <summary>
        /// Test an instance of WebhookEvent
        /// </summary>
        [Test]
        public void InstanceTestWebhookEvent()
        {
            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);

            DataObject webHookDataObject = new DataObject("webhooks", "025ba1e8-efa2-4194-a075-0386876ed1fc");

            WebhookEventObject webhookEventObject = new WebhookEventObject(webHookDataObject, relatedLinks);

            TransactionObject transactionObject = new TransactionObject(webHookDataObject, relatedLinks);

            var jWebhookEventObject = webhookEventObject.ToJson();

            WebhookEventRelationships relationships = new WebhookEventRelationships(webhookEventObject, transactionObject);

            DateTime timeNow = DateTime.Now;

            WebhookEventAttributes attributes = new WebhookEventAttributes(WebhookEventAttributes.WebhookEventTypeEnum.PING, timeNow);

            var jAttributes = attributes.ToJson();
            var jRelationships = relationships.ToJson();

            WebhookEventResource webhookEventResource = new WebhookEventResource("webhook-events", "b7a26e00-987f-41ab-87c1-0f8c72c65010", attributes, relationships);

            var jWebhookEventResource = webhookEventResource.ToJson();

            WebhookEvent instance = new WebhookEvent(webhookEventResource);

            Assert.IsInstanceOf<WebhookEvent>(instance, "variable 'eventInstance' is a WebhookEvent");
        }

        /// <summary>
        /// Test an instance of WebhookDeliveryLog
        /// </summary>
        [Test]
        public void InstanceTestWebhookDeliveryLog()
        {

            string related = "https://api.up.com.au/api/related";
            RelationshipLinks relatedLinks = new RelationshipLinks(related);

            DataObject webHookDataObject = new DataObject("webhooks", "8b955e7f-caeb-4a23-ab35-ec226640f25d");

            var jWebhookDeliveryLogObject = webHookDataObject.ToJson();

            WebhookDeliveryLogRelationships relationships = new WebhookDeliveryLogRelationships(webHookDataObject);

            DateTime timeNow = DateTime.Now;

            Request request = new Request("{\"data\":{\"type\":\"webhook-events\",\"id\":\"b4f7e69e-d9cd-4f18-863e-8db3cbfe9e5e\",\"attributes\":{\"eventType\":\"TRANSACTION_CREATED\",\"createdAt\":\"2020-09-20T14:54:40+10:00\"},\"relationships\":{\"webhook\":{\"data\":{\"type\":\"webhooks\",\"id\":\"9bd777fc-e92c-40eb-ba41-2ab102f94c06\"},\"links\":{\"related\":\"https://api.up.com.au/api/v1/webhooks/9bd777fc-e92c-40eb-ba41-2ab102f94c06\"}},\"transaction\":{\"data\":{\"type\":\"transactions\",\"id\":\"03b9f289-546f-45ab-9a7f-8f33e8624dab\"},\"links\":{\"related\":\"https://api.up.com.au/api/v1/transactions/03b9f289-546f-45ab-9a7f-8f33e8624dab\"}}}}}");
            Response response = new Response(200, "{\"ok\":true}");

            WebhookDeliveryLogAttributes attributes = new WebhookDeliveryLogAttributes(request, response, WebhookDeliveryLogAttributes.WebhookDeliveryStatusEnum.DELIVERED, timeNow);

            var jAttributes = attributes.ToJson();
            var jRelationships = relationships.ToJson();

            WebhookDeliveryLogResource webhookDeliveryLogResource1 = new WebhookDeliveryLogResource("webhook-delivery-logs", "ae43e6b9-e672-4171-a2c1-68e2ad929695", attributes, relationships);

            var jWebhookDeliveryLogResource1 = webhookDeliveryLogResource1.ToJson();

            WebhookDeliveryLogResource webhookDeliveryLogResource2 = new WebhookDeliveryLogResource("webhook-delivery-logs", "ae43e6b9-e672-4171-a2c1-68e2ad929695", attributes, relationships);

            var jWebhookDeliveryLogResource2 = webhookDeliveryLogResource2.ToJson();

            var webhookDeliveryLogResourceList = new List<WebhookDeliveryLogResource>();

            webhookDeliveryLogResourceList.Add(webhookDeliveryLogResource1);
            webhookDeliveryLogResourceList.Add(webhookDeliveryLogResource2);

            var jWebhookDeliveryLogResourceList = JsonConvert.SerializeObject(webhookDeliveryLogResourceList, Formatting.Indented);

            string previousLink = "https://api.up.com.au/api/previous";
            string nextLink = "https://api.up.com.au/api/next";
            PageLinks links = new PageLinks(previousLink, nextLink);

            WebhookDeliveryLog instance = new WebhookDeliveryLog(webhookDeliveryLogResourceList, links);

            Assert.IsInstanceOf<WebhookDeliveryLog>(instance, "variable 'deliveryLogInstance' is a WebhookDeliveryLog");
        }

        #endregion

        #region Test Functions

        /// <summary>
        /// Test all Account functions of the Api
        /// </summary>
        [Test]
        public void TestAccounts()
        {

            var account = GetAccountByName("Up Account");

            var accountList = GetAllAccounts();
            if (accountList != null)
            {
                string id = accountList.Data[0].Id;
                account = GetAccount(id);
            }

        }

        /// <summary>
        /// Test all Transaction functions of the Api
        /// </summary>
        [Test]
        public void TestTransactions()
        {
            var config = new Configuration();
            config.ApiToken = apiToken;
            var apiClient = new ApiClient(config);

            var account = GetAccountByName("Up Account");

            var transactionList = GetAllTransactionsForAccount(account.Data.Id);

        }

        /// <summary>
        /// Test all Tag functions of the Api
        /// </summary>
        [Test]
        public void TestTags()
        {

            var tagList = GetAllTags();

            var transactionList = GetAllTransactions();
            if (transactionList != null)
            {
                string id = transactionList.Data[0].Id;
                var transaction = GetTransaction(id);
                transaction = TransactionAddTag(id);
                transaction = GetTransaction(id);
                transaction = TransactionDeleteTag(id);
                transaction = GetTransaction(id);
            }

        }

        /// <summary>
        /// Test all Category functions of the Api
        /// </summary>
        [Test]
        public void TestCategories()
        {
            var categoryList = GetAllCategories();
            if (categoryList != null && categoryList.Data.Count > 0)
            {
                string id = categoryList.Data[0].Id;
                var category = GetCategory(id);
            }
        }

        /// <summary>
        /// Test all Category functions of the Api
        /// </summary>
        [Test]
        public void TestWebhooks()
        {

            var webhookList = GetAllWebhooks();
            foreach (var wh in webhookList.Data)
            {
                DeleteWebhook(wh.Id);
            }


            var webhook = CreateWebhook();
            webhookList = GetAllWebhooks();
            if (webhookList != null && webhookList.Data.Count > 0)
            {
                string id = webhookList.Data[0].Id;
                webhook = GetWebhook(id);
            }
            else
            {
                webhook = CreateWebhook();
            }

            if (webhook != null)
            {
                string id = webhook.Data.Id;
                var webhookEvent = PingWebhook(id);
                var webhookDeliveryLog = GetWebhookDeliveryLog(id);
            }
        }

        #endregion
    }
}

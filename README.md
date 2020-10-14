![.NET Core](https://github.com/SelectSystemsInternational/up-bank-api/workflows/.NET%20Core/badge.svg?branch=master&event=status)

# up-bank-api-sdk
A .Netcore SDK for the [UpBank API](https://developer.up.com.au/)

* [The Up Website](https://up.com.au/)
* [Up API Documentation](https://developer.up.com.au/)
* [Up API on Github](https://github.com/up-banking/api)

## Usage

Download this Repository which is currently built using .Netcore 3.1 in Visual Studio

## Supported modules

The following modules of the Up API are fully supported:

* [Accounts](https://developer.up.com.au/#accounts)
* [Categories](https://developer.up.com.au/#categories)
* [Transactions](https://developer.up.com.au/#transactions)
* [Tags](https://developer.up.com.au/#tags)
* [Utility](https://developer.up.com.au/#utility_endpoints)
* [Webhooks](https://developer.up.com.au/#webhooks)

## Not supported yet

This SDK was produced by manually creating all the classes by reading the specification on the developer website. 
Then I modified another Api to incorporate all the new data structures and then made some test routines.
All endpoints in the Up Bank Api are supported. The SDK has been tested with my Up Bank account.
I welcome any comments or if you find problems let me know.

Since finalising this version and coming to understand a lot more about swagger and auto code creation from an Open Specification I will revisit it and produce a new version.

I just found the openapi.json specification and loaded it into My Swagger Hub and generate a cSharp Client SDK but there was a bunch of errors when I loaded it into Visual Studio and tried to build it. Not sure if that is an error in the openapi.json or bugs in the swagger code generator. I will look into soon.

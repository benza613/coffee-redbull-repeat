# coffee-redbull-repeat
Modern webapp built in dotnet core &amp; angular powered by AWS Lambda, EC2, API Gateway &amp; DynamoDB 

## Current Status 

Still in local Development. Will setup dotnet backend next
https://dev.daaqa8qkimtgf.amplifyapp.com/

<br/>

## Current Structure 

**AWS Amplify** -- Hosting the static website, posts data to AWS API Gateway  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|  
&nbsp;&nbsp;&nbsp;&nbsp;V  
**AWS API Gateway**-- Defined a POST function to the Lambda function (HelloWorldFunction)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|  
&nbsp;&nbsp;&nbsp;&nbsp;V  
**AWS Lambda**-- Defined function that writes a log to DynamoDb (HelloWorldDatabase). Function has non-destructive IAM defined role. Returns simple JSON object to front end   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|  
&nbsp;&nbsp;&nbsp;&nbsp;V  
**AWS DynamoDB**-- Setup Test Db having primary ID key (int). 
<br/>
&nbsp;&nbsp;&nbsp;^^^  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|   
**AWS Budget Tracker** -- setup to alert at 35/40$ thresholds

<br/>

## Postman Documentation 

Dev Test Collection   
https://documenter.getpostman.com/view/11971818/TWDRtfMR
<br/>

## Why ?

Did not sleep at night. Drank coffee in the morning. Redbull in the afternoon. Decided to visit the "clouds" in the evening. **SORRY** :V 
<br/>

## Remarks 

1. Go through the basic [AWS Hands on API tutorial](https://aws.amazon.com/getting-started/hands-on/build-web-app-s3-lambda-api-gateway-dynamodb) to get a nice detailed walkthrough incase this is the first time you will be working with AWS Cloud resources. 

2. The goals are to have a working dotnet functions api, unit testing and eventually convert this project into a more complex angular portfolio hosted on the cloud.
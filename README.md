# coffee-redbull-repeat
Modern webapp built in dotnet core &amp; angular powered by AWS Lambda, EC2, API Gateway &amp; DynamoDB 


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



## Postman Documentation 

Dev Test Collection   
https://documenter.getpostman.com/view/11971818/TWDRtfMR


## Why ?

Did not sleep at night. Drank coffee in the morning. Redbull in the afternoon. Decided to visit the "clouds" in the evening. **SORRY** :V 
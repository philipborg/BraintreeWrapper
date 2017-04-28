# Braintree Wrapper

Braintree Wrapper is a app that processes payment transactions requested using another app.

Status: **Prototype**

## Trying out

To testing this app, please:

1. Start WebShop
2. Start Braintree Wrapper
3. Set up your merchant account data (see below)
4. Use test credit card data:
 - Credit card number: `4111111111111111`
 - Expiry date: `02/2018`
 - Security number: `123`

### Set merchant account data

You will need to provide your Braintree merchant account data before using the app. 

Go to `localhost:8080/braintreewrapper/settings` page and enter the following data:

- Environment 
- Merchant id 
- Public key
- Private key

The data can be obtained from the person who has configured the merchant account. You can also find it in the Braintree admin interface by going to one of the following:

1. https://sandbox.braintreegateway.com/login (when using the sandbox enviroment)
2. https://www.braintreegateway.com/login (when using the production enviroment)

Log in. Then go to `Account` -> `My user` -> on bottom of page you find `View Authorizations` button. Click there.

Next you see `API Keys` page with table. Click first of record, column name`Private Key`, next in `Client Library Key` you can find your merchant account data. That page presents all the information needed to configure BraintreeWrapper settings page.
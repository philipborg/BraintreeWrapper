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

Please set yours merchant account data before start the app. Yours mechant account you find it in account setting.

Go to:

- https://sandbox.braintreegateway.com/login (when using the sandbox enviroment) or
- https://www.braintreegateway.com/login  (when using the production enviroment)

Log in. Then go to `Account` -> `My user` -> on bottom of page you find `View Authorizations` button. Click there.

Next you see `API Keys` page with table. Click first of record, column name`Private Key`, next in `Client Library Key` you can find your merchant account data. Please stay on this page.

Next go to destination where you download the project. In `Config` folder, you can find the `BrainTreeConfig.xml` file where you must past data:

```xml
  <Enviroment>Put here from page Enviroment value</Enviroment>
  <MerchantId>Put here from page Merchant ID value</MerchantId>
  <PublicKey>Put here from page Public Key value</PublicKey>
  <PrivateKey>Put here from page Private Key value</PrivateKey>
```

Ok, when you finished, save file, and start the app, or restart the app to change affected.

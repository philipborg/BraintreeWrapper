# BrainTreeApp

BrainTree app is payment provider whereby user can pay for the items. Currently version user have to set own data, billing address and credit card informations which are required.

To testing this app, please:

Starting the basket app, then starting this app.

Then please use test credit card infomrations to try testing app (in future stored in .xml file):

Credit card number  - 4111111111111111

Expiry month - 02

Expiry year - 2017

Security number - 123

### Set merchant account data

Please set yours merchant account data before start the app. Yours mechant account you find it in account setting.

Go to:

https://sandbox.braintreegateway.com/login (when use the sandbox enviroment) or

https://www.braintreegateway.com/login  (when use the production enviroment)

Log in. Then go to ```Account``` -> ```My user``` -> on bottom of page you find ```View API Keys``` button. Click there.

Next you see ```Api Keys``` page with table. Click first of record, column name```Public Key```, next in ```Client Library Key``` you can find your merchant account data. Please stay on this page.

Next go to destination where you download the project. In ```Config``` folder, you can find the ```BrainTreeConfig.xml``` file where you must past data:

```
  <Enviroment>Put here from page Enviroment value</Enviroment>
  <MerchantId>Put here from page Merchant ID value</MerchantId>
  <PublicKey>Put here from page Public Key value</PublicKey>
  <PrivateKey>Put here from page Private Key value</PrivateKey>
```

Ok, when you finished, save file, and start the app, or restart the app to change affected.

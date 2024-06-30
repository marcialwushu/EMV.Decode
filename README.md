# EMV e Jwt Decode

## PayloadJwt 

```
Informe o JWT:
eyJhbGciOiJQUzI1NiIsImtpZCI6IjdkOTZiMTU3NDczZDVmOGFlYTBmNTAwNWJmNjllN2JmNGVhZDZhNzQ0OTIxN2Q0NTIxOWZiN2MzZDAzOGFhNTIiLCJ4NXQiOiJ4RVE0YlVocmEzSmZ1MHhMRlNEeGVQN0tKQU0iLCJqa3UiOiJodHRwczovL3FyLml1Z3UuY29tL3B1YmxpYy9qd3QvandrcyJ9.eyJyZXZpc2FvIjoxLCJjYWxlbmRhcmlvIjp7ImNyaWFjYW8iOiIyMDI0LTA2LTI5VDAxOjMzOjM2WiIsImV4cGlyYWNhbyI6OTU1NTgzLCJhcHJlc2VudGFjYW8iOiIyMDI0LTA2LTI5VDAxOjMzOjM2WiJ9LCJ2YWxvciI6eyJvcmlnaW5hbCI6IjQ1LjAwIn0sImNoYXZlIjoiNWNmOTYyOWMtMTE0ZC00ZGIyLThhYTQtNzMzNjRmMjUyMWJkIiwidHhpZCI6IkMxNzAwNzdFNEE3QjRFMjQ4QkJGQUUyRDc2OUYxODExIiwic3RhdHVzIjoiQVRJVkEifQ.lxjkGh_p8ztTeL-V7ui7bFll6aqXiKxfRG39CG03bHJsgyHG5TQ-usWLb8u2Kjvcla92RwQFbr_KL1AihS9VT3cIcBZ-xf3Z2QFoqYfIiAbssPxUbaI4OxOL-MRk1HG7PVxsze9Z3IcyxttTAcY5XM5e1KZ9LhJ_rSkuYpb3QbX1RNm4TwjQVhAM64ZJGhQGhvj1i3y2rcvGSKWhwwuL4PHg9eb8SF3AF8-M7T2wA6el5Dt6EapQ-GrfyTU9pRp-rzlEs2w3oaBSk2z7XvyrtvChh2ZASD7vntOavrbSWaFctxjiTbdcOkpCW_tPandLzx0PdQpm2wElIjSPtIUbDA
Header JSON:
{
  "alg": "PS256",
  "kid": "7d96b157473d5f8aea0f5005bf69e7bf4ead6a7449217d45219fb7c3d038aa52",
  "x5t": "xEQ4bUhra3Jfu0xLFSDxeP7KJAM",
  "jku": "https://qr.iugu.com/public/jwt/jwks"
}
Payload JSON:
{
  "revisao": 1,
  "calendario": {
    "criacao": "2024-06-29T01:33:36Z",
    "expiracao": 955583,
    "apresentacao": "2024-06-29T01:33:36Z"
  },
  "valor": {
    "original": "45.00"
  },
  "chave": "5cf9629c-114d-4db2-8aa4-73364f2521bd",
  "txid": "C170077E4A7B4E248BBFAE2D769F1811",
  "status": "ATIVA"
}
Claims JSON:
[
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "revisao",
    "Value": "1",
    "ValueType": "http://www.w3.org/2001/XMLSchema#integer32"
  },
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "calendario",
    "Value": "{\u0022criacao\u0022:\u00222024-06-29T01:33:36Z\u0022,\u0022expiracao\u0022:955583,\u0022apresentacao\u0022:\u00222024-06-29T01:33:36Z\u0022}",
    "ValueType": "JSON"
  },
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "valor",
    "Value": "{\u0022original\u0022:\u002245.00\u0022}",
    "ValueType": "JSON"
  },
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "chave",
    "Value": "5cf9629c-114d-4db2-8aa4-73364f2521bd",
    "ValueType": "http://www.w3.org/2001/XMLSchema#string"
  },
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "txid",
    "Value": "C170077E4A7B4E248BBFAE2D769F1811",
    "ValueType": "http://www.w3.org/2001/XMLSchema#string"
  },
  {
    "Issuer": "LOCAL AUTHORITY",
    "OriginalIssuer": "LOCAL AUTHORITY",
    "Properties": {},
    "Subject": null,
    "Type": "status",
    "Value": "ATIVA",
    "ValueType": "http://www.w3.org/2001/XMLSchema#string"
  }
]
revisao: 1
calendario: {"criacao":"2024-06-29T01:33:36Z","expiracao":955583,"apresentacao":"2024-06-29T01:33:36Z"}
valor: {"original":"45.00"}
chave: 5cf9629c-114d-4db2-8aa4-73364f2521bd
txid: C170077E4A7B4E248BBFAE2D769F1811
status: ATIVA
```

## Pix Copia e cola 

```
Informe o código Pix (copia e cola):
00020101021226840014br.gov.bcb.pix2562qr.iugu.com/public/payload/v2/C170077E4A7B4E248BBFAE2D769F1811520400005303986540545.005802BR5925CLOSE FANS TECNOLOGIA LTD6014BELO HORIZONTE62070503***6304F03B
======================================
(00) Payload Format Indicator : 01
(01) Point of Initiation Method : 12
(26) Merchant Account Information : 0014br.gov.bcb.pix2562qr.iugu.com/public/payload/v2/C170077E4A7B4E248BBFAE2D769F1811
(52) Merchant Category Code : 0000
(53) Transaction Currency : 986
(54) Transaction Amount : 45.00
(58) Country Code : BR
(59) Merchant Name : CLOSE FANS TECNOLOGIA LTD
(60) Merchant City : BELO HORIZONTE
(62) Additional Data Field Template : 0503***
(63) CRC : F03B
```

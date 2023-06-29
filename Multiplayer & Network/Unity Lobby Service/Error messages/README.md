## Error messages
The Lobby service returns errors in the "problem details" format ([RFC 7807](https://www.rfc-editor.org/rfc/rfc7807)) including some additional fields that are consistent with most other UGS services.


Example:


```cs
{
  "title": "Bad Request",
  "status": 400,
  "code": 16000,
  "detail": "request failed validation",
  "details": [
    {
      "errorType": "validation",
      "message": "count in body should be less than or equal to 100"
    }
    {
      "errorType": "validation",
      "message": "skip in body should be greater than or equal to 0"
    }
  ],
  "type": "http://unity3d/lobby/errors/validation-error"
}


```


### ref
https://docs.unity.com/lobby/en-us/manual/lobby-error-messages

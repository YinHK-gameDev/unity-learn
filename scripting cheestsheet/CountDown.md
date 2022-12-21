## Countdown

**Method 1**
```cs
public float timeStart = 60;
public Text textBox;
// Use this for initialization
void Start() {
  textBox.text = timeStart.ToString();
}	
// Update is called once per frame
void Update () {
  timeStart -= Time.deltaTime;
  textBox.text = Mathf.Round(timeStart).ToString();
}
```

**Method 2**
```cs
StartCoroutine(CountdownTimer(60));
//Set a count down timer
IEnumerator  CountdownTimer(float timer) {
 while(timer > 0){
    yield return null;
    timer -= Time.deltaTime;
    timeText.text = "Time: " + Mathf.Round(timer).ToString();
 }
}
```
**Method 3(better)**
```cs
StartCoroutine(CountdownTimer(60));
//Set a count down timer
IEnumerator  CountdownTimer(float timer) {
	while(timer > 0) {
	  yield return new WaitForSeconds(1);
	  timer --;
	  timeText.text = "Time: " + Mathf.Round(timer).ToString();
  }
}
```



# Session 1/Example 3

Exempelkod för andra delen av filmklippet:

**C# Async/Await/Task Explained (Deep Dive) (24:21 min)<br>
https://www.youtube.com/watch?v=il9gl8MH17s.**

## Info
.NET Core console app som innehåller två "körningar":

- En asynkron variant, men trots allt singel-trådad, som skriver ut thread id:
<pre>
Do things asynchronously, long busy wait => same thread id
==========================================================
|1
|thread id: 1

|2
|thread id: 1

|3
|thread id: 1

|4
|thread id: 1

|5
|thread id: 1
</pre>

- En asynkron variant, som ger flera trådar, skriver ut thread id:
<pre>
Do things asynchronously, short busy wait => multiple thread ids
================================================================
|1
|thread id: 1

|2
|thread id: 1

|3
|thread id: 1

|4
|thread id: 1

|5
|thread id: 11
</pre>

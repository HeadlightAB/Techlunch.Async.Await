# Session 1/Example 2

Exempelkod för första delen av filmklippet:

**C# Async/Await/Task Explained (Deep Dive) (24:21 min)<br>
https://www.youtube.com/watch?v=il9gl8MH17s.**

## Info
.NET Core console app som innehåller tre "körningar":

- En synkron kokning av te:
<pre>
Making tea synchronously
========================
Start the kettle
waiting for the kettle
kettle finished boiling
take the cups out
put tea in cups
pour water in cups
</pre>

- En asynkron kokning av te, UTAN busy-wait:
<pre>
Making tea asynchronously, no busy wait
=======================================
Start the kettle
waiting for the kettle
take the cups out
put tea in cups
kettle finished boiling
pour water in cups
</pre>

- En asynkron kokning av te, MED busy-wait:
<pre>
Making tea asynchronously, busy wait
====================================
Start the kettle
waiting for the kettle
take the cups out
kettle finished boiling
put tea in cups
pour water in cups
</pre>

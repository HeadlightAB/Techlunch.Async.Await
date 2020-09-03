# Session 1/Example 1
.NET Core console app som innehåller två "körningar":

- En synkron worker [WorkerDemo.cs](Example_1/WorkerDemo.cs), som helt enkelt kommer att pausa i metoden LongOperation.
<pre>
Running worker demo
===================

Starting worker
Doing work
Working!
Work completed
Worker done

</pre>

- En asynkron worker [ModifiedWorker.cs](Example_1/ModifiedWorkerDemo.cs), som ger utskrift av förloppet '.....' då metoden LongOperation skapar en ny task och gör exekveringen asykron.
<pre>
Running modified worker demo
============================

Starting modified worker
Doing work
Working!
...................
Work completed
Modified worker done
</pre>

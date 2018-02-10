# Demo of pattern matching in C# 7 for event-sourced aggregates

This is an over-simplified demo on how to use the new feature of C# - advanced pattern matching - to handle events in aggregates
and projections.

Hence that command handling also uses pattern matching. You find similar code in samples for the Proto.actor framework.
However, if you have more complex application, this simplified approach might not work for you. Consider handling commands
in an application service or command handler class, which will also manage your dependencies. The aggregate should never
have any dependencies.

The code for applying aggregate events and for handling projections is quite allright.

### Disclaimer
This is a demo code and it is not production ready.

### Further
You can check the [lab repository](https://github.com/UbiquitousAS/WorkshopEventSourcing) for the Practical Event-Soucring with C# hands-on session that me 
and [@ragingkore](https://twitter.com/ragingkore?lang=en) delivered on DDD Europe 2018.

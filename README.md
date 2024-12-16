### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Chain of responsability pattern
Chain of responsability is usefull in Web application middleware pipeline or in Desktop application between every visual component linkedd by a chain of event. \
Benefits: 
- client decoupled from the chain of handlers (needs only initial handler)
- is possibile to reorder handlers, change handlers or so on
- every handler should be small and reusable in many situation
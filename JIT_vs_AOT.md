## Single-page application
Single page application is a web application or website that interacts with users by rewriting the current web page with new data from web server. All the interactions will happen in just one page where users can see, instead of opening another page to load the data. Single page application is quick and exposes richer features. A good example would be gmail. 

## JIT VS AOT
### JIT (JUST IN TIME)
•	Compile at run time. codes are compiled when are needed, not at the build time. instead of converting to byte code at build time, 
it will compile byte code when component is called.  not all code compiled initially\
•	Compiles file separately and mostly in browser.\
•	Most compiling done at browser, less compiling time.\
•	Best to use when application is in local development.\
•	Run app using ng build OR ng serve

### AOT(AHEAD OF TIME)
•	Compile or convert high-level language into codes that machine understands, therefore it is system dependent.\ 
•	When server builds angular, AOT will convert the code during the build time (build solution) before the browser downloads and runs the code.\
•	It minimizes the size of application\
•	Since AOT compiles during build, it renders the component faster\
•	Because it is compiled at run time, it detects error earlier\
•	Provides better security since compilation is done before displaying to users, avoid injection attack.\
•	Run app using ng build - -aot OR ng serve - -aot

## Directives vs pipes
### Directives:
•	not used to play with data, it is used to work with DOM, like button or input.\
•	To alter the behavior or appearance of an element 

### Pipes:
•	work with data. \
•	Used for formatting data

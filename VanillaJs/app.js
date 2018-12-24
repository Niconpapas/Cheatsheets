//Book Class
class Book{
    constructor(tittle,author,isbn){
        this.tittle=tittle;
        this.author=author;
        this.isbn=isbn;
    }
}

//UI Class
class UI{
    static displayBooks(){
        // const StoredBooks=[
        //     {
        //         tittle:'Book One',
        //         author:'Alguien lul',
        //         isbn:'23232323'
        //     },
        //     {
        //         tittle:'Book Two',
        //         author:'adsasd',
        //         isbn:'123123'
        //     }
        // ];

        const books=Store.getBooks();

        books.forEach((book)=>UI.addBookToList(book));
        
        
        
        

    }

    static addBookToList(book){
        const list=document.querySelector('#book-list');
        const row=document.createElement('tr');

        row.innerHTML=`
            <td>${book.tittle}</td>
            <td>${book.author}</td>
            <td>${book.isbn}</td>
            <td><a href="#" class="btn btn-danger btn-sm delete">x</a></td>
        `;

        list.appendChild(row);

    }

    static deleteBook(el){
        if(el.classList.contains('delete')){
            el.parentElement.parentElement.remove();
        }
    }

    static showAlert(message, className){
        const div=document.createElement('div');
        
        div.className=`alert text-center alert-${className}`;
        div.appendChild(document.createTextNode(message));
        
        const container=document.querySelector('.container');

        const form=document.querySelector('#book-form');

        container.insertBefore(div,form);
        
        //Vanish in  3 sec
        setTimeout(()=>document.querySelector('.alert').remove(),3000);

    }

    static clearFields(){
        document.querySelector('#tittle').value='';
        document.querySelector('#author').value='';
        document.querySelector('#isbn').value='';
    }
}

//Store Class
class Store{
    static getBooks(){
        var books;
        if(localStorage.getItem('books')===null){
            books = [];
        }else{
            books= JSON.parse(localStorage.getItem('books'));
        }

        return books;
    }

    static addBook(book){
        const books= Store.getBooks();

        books.push(book);

        localStorage.setItem('books',JSON.stringify(books));
    }

    static removeBook(isbn){
        const books=Store.getBooks();

        books.forEach((book,index)=>{
            if(book.isbn===isbn){
                books.splice(index, 1);
            }
        });

        localStorage.setItem('books',JSON.stringify(books));
    }
}

//Events:Display Book
document.addEventListener('DOMContentLoaded',UI.displayBooks);

//Event:Add book
document.querySelector('#book-form').addEventListener('submit',(e)=>{
    //prevent submit
    e.preventDefault();

    //Get Form Values
    const tittle=document.querySelector('#tittle').value;
    const author=document.querySelector('#author').value;
    const isbn=document.querySelector('#isbn').value;

    //Validation
    if(tittle===''||author===''||isbn===''){
        UI.showAlert('Fill all Fields','danger');
    }else{
        //Intantiate book
        const book=new Book(tittle,author,isbn);

        //console.log(book);

        //Add to Storage
        Store.addBook(book);

        //Add Book Ui

        UI.addBookToList(book);
        UI.showAlert('Book Added','success');

        //Clear Fields
        UI.clearFields();

    }

    
});

//Event:Remove Book
document.querySelector('#book-list').addEventListener('click',(e)=>{
    //Remove from UI
    UI.deleteBook(e.target);

    //Remove from Store
    Store.removeBook(e.target.parentElement.previousElementSibling.textContent);

    //Alert
    UI.showAlert('Book removed','success');

});
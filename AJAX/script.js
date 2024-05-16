// XmlHttpRequest

console.log(`Start of code`);

let xhr = new XMLHttpRequest();

xhr.open("GET", "https://jsonplaceholder.typicode.com/posts", false);

xhr.onload = function () {
  if (this.status === 200) {
    let posts = JSON.parse(this.responseText);
    console.log(posts);
  }
};

xhr.send();

console.log(`End of code`);

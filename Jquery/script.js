console.log($(`h1`));

// setInterval(() => {
//   $(`h1`).fadeToggle(1000);
// }, 1000);

$.ajax({
  method: `GET`,
  url: `https://api.github.com/users/colt`,
})
  .done(function (data) {
    console.log(data);
  })
  .fail(function () {
    console.log(`ERROR!`);
  });

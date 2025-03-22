// -------1
let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130,
};

let sum = 0;
for (let key in salaries) {
  sum += salaries[key];
}
console.log(sum); // 390

// -------2
function multiplyNumeric(obj) {
  for (let key in obj) {
    if (typeof obj[key] === "number") {
      obj[key] *= 2;
    }
  }
}

let menu = {
  width: 200,
  height: 300,
  title: "My menu",
};

multiplyNumeric(menu);
console.log(menu);
// { width: 400, height: 600, title: "My menu" }

// -------3
function checkEmailId(str) {
  str = str.toLowerCase();
  let atPos = str.indexOf("@");
  let dotPos = str.indexOf(".", atPos + 1);
  return atPos > 0 && dotPos > atPos + 1;
}

// -------4
function truncate(str, maxlength) {
  if (str.length > maxlength) {
    return str.slice(0, maxlength - 1) + "…";
  }
  return str;
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

// -------5
let styles = ["James", "Brennie"];
styles.push("Robert"); // ["James", "Brennie", "Robert"]

let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin"; // ["James", "Calvin", "Robert"]

styles.shift(); // ["Calvin", "Robert"]

styles.unshift("Rose", "Regal"); // ["Rose", "Regal", "Calvin", "Robert"]

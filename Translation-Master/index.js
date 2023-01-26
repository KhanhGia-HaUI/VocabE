"use strict";
import translate from 'google-translate-api-x';
import fs from 'node:fs';
const json = JSON.parse(fs.readFileSync("main.json"));
const json_keys = Object.keys(json);
const json_value = Object.values(json);
const json_arr = new Array();
if (json_keys.length == json_value.length) {
    for (const i in json_keys) {
        const word_translate = await translate(json_keys[i], { to: 'vi' }).finally((result) => {
            return result;
        });
        const desc_translate = await translate(json_value[i], { to: 'vi' }).finally((result) => {
            return result;
        });
        json_arr.push({ english: json_keys[i], vietnamese: word_translate, english_description: json_value[i], vietnamese_description: desc_translate });
    };
};
await fs.writeFileSync("point.json", JSON.stringify({ credits: "secretuser and his awesome secret-package-for-my-own-use. Link: https://www.npmjs.com/package/secret-package-for-my-own-use", groups: json_arr }, null, '\t'))

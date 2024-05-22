import React from "react";
import style from "./Regress.module.scss";
import Button from '@mui/material/Button';
import TextField  from '@mui/material/TextField';
import RadioGroup from '@mui/material/RadioGroup';
import FormControlLabel from "@mui/material/FormControlLabel";
import Radio from "@mui/material/Radio";


const Regress = () => {
    return (
        <div className={style.wrapper}>
            <div className={style.radioButtons}>
                <input type="radio" name="regress" id={style.regressrun} defaultChecked={true} />
                <label htmlFor={style.regressrun}
                    id={style.runLabel}>
                    Запуск тестов
                </label>
                <input type="radio" name="regress" id={style.reggreshistory}/>
                <label htmlFor={style.reggreshistory}
                    id={style.historyLabel}>
                    История тестов
                </label>
            </div>
            <div className={style.runForm}>
                <form>
                <TextField id="outlined-basic" label="Интеграция" variant="outlined" />
                <RadioGroup
                    defaultValue="dev"
                    name="radio-buttons-group"
                    >
                    <FormControlLabel value="dev" control={<Radio />} label="dev" />
                    <FormControlLabel value="stage" control={<Radio />} label="stage" />
                    <FormControlLabel value="prod" control={<Radio />} label="prod" />
                </RadioGroup>
                <RadioGroup
                    defaultValue="dev"
                    name="radio-buttons-group"
                    >
                    <FormControlLabel value="dev" control={<Radio />} label="dev" />
                    <FormControlLabel value="stage" control={<Radio />} label="stage" />
                    <FormControlLabel value="prod" control={<Radio />} label="prod" />
                </RadioGroup>
                    <textarea
                        placeholder={"Список тем через запятую"}
                        autoComplete={"off"} />
                        <Button variant="contained">Ы</Button>
                </form>
            </div>
            <div className={style.historyForm}>
                <form>
                    <h4>История запусков</h4>
                </form>
            </div>
        </div>
    );
}
export default Regress;
import React from "react";
import style from "./Regress.module.scss";
import Button from '@mui/material/Button';
import TextField  from '@mui/material/TextField';
import RadioGroup from '@mui/material/RadioGroup';
import FormControlLabel from "@mui/material/FormControlLabel";
import Radio from "@mui/material/Radio";
import { useMemo } from 'react';
import {
  MaterialReactTable,
  useMaterialReactTable,
  type MRT_ColumnDef,
} from 'material-react-table';


type RegressH = {
  name: {
    firstName: string;
    lastName: string;
  };
  address: string;
  city: string;
  state: string;
};


const data: RegressH[] = [
  {
    name: {
      firstName: 'John',
      lastName: 'Doe',
    },
    address: '261 Erdman Ford',
    city: 'East Daphne',
    state: 'Kentucky',
  },
  {
    name: {
      firstName: 'Jane',
      lastName: 'Doe',
    },
    address: '769 Dominic Grove',
    city: 'Columbus',
    state: 'Ohio',
  },
  {
    name: {
      firstName: 'Joe',
      lastName: 'Doe',
    },
    address: '566 Brakus Inlet',
    city: 'South Linda',
    state: 'West Virginia',
  },
  {
    name: {
      firstName: 'Kevin',
      lastName: 'Vandy',
    },
    address: '722 Emie Stream',
    city: 'Lincoln',
    state: 'Nebraska',
  },
  {
    name: {
      firstName: 'Joshua',
      lastName: 'Rolluffs',
    },
    address: '32188 Larkin Turnpike',
    city: 'Omaha',
    state: 'Nebraska',
  },
];

  export default function Regress() {
     //should be memoized or stable
  const columns = useMemo<MRT_ColumnDef<RegressH>[]>(
    () => [
      {
        accessorKey: 'name.firstName', //access nested data with dot notation
        header: 'First Name',
        size: 150,
      },
      {
        accessorKey: 'name.lastName',
        header: 'Last Name',
        size: 150,
      },
      {
        accessorKey: 'address', //normal accessorKey
        header: 'Address',
        size: 200,
      },
      {
        accessorKey: 'city',
        header: 'City',
        size: 150,
      },
      {
        accessorKey: 'state',
        header: 'State',
        size: 150,
      },
    ],
    [],
  );

  const table = useMaterialReactTable({
    columns,
    data,
  });
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
                <TextField id="outlined-basic" label="Список тем" variant="outlined" />
                        <Button variant="contained">Запустить тесты</Button>
                </form>
            </div>
            <div className={style.historyForm}>
                <form>
                <MaterialReactTable table={table} />
                </form>
            </div>
        </div>
    );
}
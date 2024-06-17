import { useMemo } from 'react';
import {
  MaterialReactTable,
  useMaterialReactTable,
  type MRT_ColumnDef,
} from 'material-react-table';

type Project = {
  title: string
  description: string;
  countTP: number;
  countTK: number;
};

const data: Project[] = [
  {
    title: 'SB2',
    description: 'Главный проект компании, тут находится документация ко всему функционалу проекта',
    countTP: 100,
    countTK: 212,
  },
  {
    title: 'TerminalQA',
    description: 'Терминальный проект',
    countTP: 20,
    countTK: 103,
  },
  {
    title: 'FE QA',
    description: 'Проект команды FE QA',
    countTP: 150,
    countTK: 145,
  },
  {
    title: 'Regress',
    description: 'Проект для запуска регрессионного тестирования',
    countTP: 14,
    countTK: 17,
  },
  {
    title: 'Auto QA',
    description: 'Проект для написания тестов к API',
    countTP: 3,
    countTK: 40,
  },
];

const Spaces = () => {
  //should be memoized or stable
  const columns = useMemo<MRT_ColumnDef<Project>[]>(
    () => [
      {
        accessorKey: 'title', //access nested data with dot notation
        header: 'Название',
        size: 150,
      },
      {
        accessorKey: 'description', //normal accessorKey
        header: 'Описание',
        size: 250,
      },
      {
        accessorKey: 'countTP',
        header: 'Количество тест-планов',
        size: 120,
      },
      {
        accessorKey: 'countTK',
        header: 'Количество кейсов',
        size: 120,
      },
    ],
    [],
  );

  const table = useMaterialReactTable({
    columns,
    data, //data must be memoized or stable (usecountTK, useMemo, defined outside of this component, etc.)
  });

  return <MaterialReactTable table={table} />;
};

export default Spaces;
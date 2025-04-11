-- migrate:up
insert into languages (short_name, name)
values ('EN', 'English'),
       ('NL', 'Dutch'),
       ('FR', 'French');

-- migrate:down
delete from languages
where short_name in ('EN', 'NL', 'FR');

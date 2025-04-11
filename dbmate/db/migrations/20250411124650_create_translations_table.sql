-- migrate:up
create table if not exists translations (
  id serial primary key,
  native_language_id integer not null references languages(id),
  native_language_word text not null,
  target_language_id integer not null references languages(id),
  target_language_word text not null,
  unique (native_language_word, target_language_word)
)

-- migrate:down
drop table if exists translations;

-- migrate:up
create table if not exists languages (
  id serial primary key,
  short_name text not null,
  name text not null
)

-- migrate:down
drop table if exists languages;

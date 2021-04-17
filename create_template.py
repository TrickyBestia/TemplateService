#!/usr/bin/python
from pathlib import Path
import os
import sys

REPLACEMENTS = {'AuthorName': '{{cookiecutter.author}}',
                'TemplateService': '{{cookiecutter.service_name}}'}


def replace(text):
    for key, value in REPLACEMENTS.items():
        text = text.replace(key, value)
    return text


os.chdir(sys.path[0])
for root, _, files in os.walk('TemplateService'):
    os.makedirs(replace(root))
    for file in [os.path.join(root, file) for file in files]:
        Path(replace(file)).write_text(replace(Path(file).read_text()))
os.system(
    'mkdir template && cp -r {{cookiecutter.service_name}} template && cp cookiecutter.json template')
